
namespace ICSharpCode.NRefactory.CSharp
{
	static class Extensions
	{
		public static T WithAnnotation<T>(this T node, object annotation) where T : AstNode
		{
			if (annotation != null)
				node.AddAnnotation(annotation);
			return node;
		}
	}
}
