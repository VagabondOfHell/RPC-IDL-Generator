using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCGeneration
{
    public struct Parameter
    {
        private string parameterName;

        public string ParameterName
        {
            get { return parameterName; }
            set { parameterName = value; }
        }

        private string parameterDatatype;

        public string ParameterDatatype
        {
            get { return parameterDatatype; }
            set { parameterDatatype = value; }
        }

        private string parameterEndpoint;

        public string ParameterEndpoint
        {
            get { return parameterEndpoint; }
            set { parameterEndpoint = value; }
        }

        public Parameter(string name, string dataType, string endPoint)
        {
            parameterName = name;
            parameterDatatype = dataType;
            parameterEndpoint = endPoint;
        }

        public void SetName(string paramName)
        {
            if (paramName != String.Empty)
                parameterName = paramName;
        }

        public void SetDatatype(string dataType)
        {
            if (dataType != String.Empty)
                parameterDatatype = dataType;
        }

        public void SetEndpoint(string endpoint)
        {
            if (endpoint != String.Empty)
                parameterEndpoint = endpoint;
        }

        public string ToString()
        {
            return ("EndPoint: " + parameterEndpoint + " Datatype: " + parameterDatatype + " Name: " + parameterName);
        }
    }
}
