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
    [Activity(Label = "�ڶ�������")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            // Create your application here

            Title = "�ڶ��������ض�������";

            //���մ������Ĳ�������ʾ�ڴ�����
            TextView tvMsg = FindViewById<TextView>(Resource.Id.tvMsg);
            var count = Intent.GetIntExtra(MainActivity.ClickCountExtra,0);
            tvMsg.Text += "�������ڵ���ˣ�" + count + "��";

            //���ذ�ť
            FindViewById<Button>(Resource.Id.btnBack).Click += (sender,e) =>
            {
                //������ǰ���岢���ص�������
                this.Finish();
            };
        }
    }
}