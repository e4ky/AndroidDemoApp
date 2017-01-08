using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidApp.DemoApp1
{
    [Activity(Label = "第二个窗口")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            // Create your application here

            Title = "第二个窗口重定义名称";

            //接收传过来的参数，显示在窗体中
            TextView tvMsg = FindViewById<TextView>(Resource.Id.tvMsg);
            var count = Intent.GetIntExtra(MainActivity.ClickCountExtra,0);
            tvMsg.Text += "，主窗口点击了：" + count + "次";

            //返回按钮
            FindViewById<Button>(Resource.Id.btnBack).Click += (sender,e) =>
            {
                //结束当前窗体并返回到主窗体
                this.Finish();
            };
        }
    }
}