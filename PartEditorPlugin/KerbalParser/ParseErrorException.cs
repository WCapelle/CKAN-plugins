using System;
using System.Runtime.Serialization;

namespace PartEditorPlugin.KerbalParser
{
	[Serializable]
	public class ParseErrorException : Exception
	{
		public ParseErrorException(string message) : base(message) {}

		public ParseErrorException(
			SerializationInfo info,
			StreamingContext ctxt) : base(info, ctxt) {}
	}
}
