using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Cofdream.Runtime
{
    public class Temp : MonoBehaviour
    {
        public Text Text;
        public Text Text2;

        // Start is called before the first frame update
        void Start()
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();

            stringBuilder.AppendLine("����:  ");
            stringBuilder2.AppendLine("����ID:  ");

            var processes = Process.GetProcesses();// ��ȡ���ؼ�����ϵĽ���
            foreach (var item in processes)
            {
                if (item != null)
                {
                    if (item.ProcessName.Contains("Unity"))
                    {
                        stringBuilder.Append(item.ProcessName);
                        stringBuilder.AppendLine();

                        
                        stringBuilder2.Append(item.Id);
                        stringBuilder2.AppendLine();
                    }
                }
            }

            Text.text = stringBuilder.ToString();
            Text2.text = stringBuilder2.ToString();
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
