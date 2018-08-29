﻿/*************************************************************************

   Copyright (C) 2018. rollrat All Rights Reserved.

   Author: Jeong HyunJun

***************************************************************************/

using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dc_crawler_cs
{
    static class Util
    {
        public static WebClient PlainWebClient()
        {
            WebClient wc = new WebClient();
            wc.Headers["Accept-Encoding"] = "application/x-gzip";
            wc.Encoding = Encoding.UTF8;
            return wc;
        }

        /// <summary>
        /// Catch exception and give options to the task.
        /// </summary>
        /// <param name="task">A task to start and forget.</param>
        /// <param name="detach">Start the task in different thread.</param>
        /// <param name="messageBox">Show messagebox when exception occurs.</param>
        public async static void Catch(this Task task, bool detach = true, bool messageBox = false)
        {
            try { await (detach ? Task.Run(() => task) : task).ConfigureAwait(false); }
            catch (Exception e)
            {
                string log = $"[Task Exception] {e.Message}\r\n{e.Source}\r\n{e.StackTrace}";
                if (messageBox) MessageBox.Show(
                    "프로그램 내부에서 예외처리되지 않은 오류가 발생했습니다. " +
                    $"오류가 계속된다면 개발자에게 문의하십시오.\n{e.Source}\n" +
                    $"StackTrace: {e.StackTrace}");
            }
        }

        public static T Send<T>(this Control control, Func<T> func)
            => control.InvokeRequired ? (T)control.Invoke(func) : func();

        public static void Post(this Control control, Action action)
        {
            if (control.InvokeRequired) control.BeginInvoke(action);
            else action();
        }
    }
}
