using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCGeneration
{
    public struct Method
    {
        private string methodName;

        public string MethodName
        {
            get { return methodName; }
            set { methodName = value; }
        }
        
        private List<Parameter> parameters;

        public List<Parameter> Parameters
        {
            get { return parameters; }
        }
        

        public Method(string name)
        {
            methodName = name;
            parameters = new List<Parameter>();
        }

        public void AddNewParameter(Parameter parameter)
        {
            parameters.Add(parameter);
        }

        public void AddNewParameter(string name, string dataType, string endpoint)
        {
            Parameter param = new Parameter(name, dataType, endpoint);
            parameters.Add(param);
        }

        public void RemoveParameter(int index)
        {
            parameters.RemoveAt(index);
        }

        public void RemoveParameter(Parameter parameter)
        {
            parameters.Remove(parameter);
        }

        public void RemoveParameter(string paramName)
        {
            for (int i = 0; i < parameters.Count; i++)
            {
                if (parameters[i].ParameterName == paramName)
                {
                    parameters.RemoveAt(i);
                }
            }
        }

        public void EditParamName(int index, string newParamName)
        {
            Parameter param = parameters[index];
            param.SetName(newParamName);

            parameters.Insert(index, param);
            parameters.RemoveAt(index + 1);             
        }

        public void EditParamDatatype(int index, string dataType)
        {
            Parameter param = parameters[index];
            param.SetDatatype(dataType);

            parameters.Insert(index, param);
            parameters.RemoveAt(index + 1);
            
        }

        public void EditParamEndpoint(int index, string endPoint)
        {
            Parameter param = parameters[index];
            param.SetEndpoint(endPoint);

            parameters.Insert(index, param);
            parameters.RemoveAt(index + 1);   
        }
    }
}
