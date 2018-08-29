/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

using dc_crawler_cs.DCInside;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dc_crawler_cs
{
    public class Queue
    {
        public int capacity = 12;
        public int mtx = 0;
        public List<string> queue = new List<string>();

        public int Capacity { get { return capacity; } set { capacity = value; } }

        public delegate void DownloadCallBack(string url, string result);
        DownloadCallBack download_callback;

        object int_lock = new object();
        object notify_lock = new object();

        public Queue(DownloadCallBack callback)
        {
            download_callback = callback;
        }

        private void DownloadRemoteString(string url)
        {
            RETRY:
            string result;
            try
            {
                result = Common.GetUrlTextAsync(url).Result;
            }
            catch
            {
                goto RETRY;
            }

            lock (download_callback) download_callback(url, result);

            lock (queue)
            {
                int at = 0;
                for (; at < queue.Count; at++)
                    if (queue[at] == url)
                        break;
                if (at != queue.Count) queue.RemoveAt(at);
            }

            lock (int_lock) mtx--;
            lock (notify_lock) Notify();
        }

        public void Add(string url)
        {
            queue.Add(url);
            if (Wait())
                lock (notify_lock) Notify();
        }

        private void Notify()
        {
            int i = mtx;
            if (queue.Count > i)
            {
                string s1 = queue[i];
                Task.Run(() => DownloadRemoteString(s1));
                lock (int_lock) mtx++;
            }
        }

        private bool Wait()
        {
            if (mtx == capacity)
                return false;
            return true;
        }
    }
}
