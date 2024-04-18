// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Custom/Water"
{
	Properties
	{
		[HideInInspector] __dirty( "", Int ) = 1
		_MaskClipValue( "Mask Clip Value", Float ) = 0.47
		_dirty_water("dirty_water", 2D) = "white" {}
		_Watertiling("Water tiling", Range( 1 , 400)) = 1
		_Color0("Color 0", Color) = (0.716,0.716,0.716,0)
	}

	SubShader
	{
		Tags{ "RenderType" = "Transparent"  "Queue" = "Geometry+0" "IsEmissive" = "true"  }
		Cull Back
		Blend SrcAlpha OneMinusSrcAlpha
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf Standard keepalpha  noshadow noambient novertexlights nolightmap  nodynlightmap nodirlightmap vertex:vertexDataFunc 
		struct Input
		{
			float2 texcoord_0;
		};

		uniform float4 _Color0;
		uniform sampler2D _dirty_water;
		uniform float _Watertiling;
		uniform float _MaskClipValue = 0.47;

		void vertexDataFunc( inout appdata_full v, out Input o )
		{
			UNITY_INITIALIZE_OUTPUT( Input, o );
			float2 temp_cast_0 = _Watertiling;
			o.texcoord_0.xy = v.texcoord.xy * temp_cast_0 + float2( 0,0 );
		}

		void surf( Input i , inout SurfaceOutputStandard o )
		{
			o.Emission = ( _Color0 * tex2D( _dirty_water,i.texcoord_0) ).xyz;
			o.Alpha = 1;
		}

		ENDCG
	}
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=6001
2567;29;1666;974;946.6992;171.7004;1;True;True
Node;AmplifyShaderEditor.RangedFloatNode;4;-1143.3,-10.6001;Float;False;Property;_Watertiling;Water tiling;1;0;1;1;400;FLOAT
Node;AmplifyShaderEditor.TextureCoordinatesNode;2;-853.2999,-0.6000977;Float;False;0;-1;2;0;FLOAT2;1,1;False;1;FLOAT2;0,0;False;FLOAT2;FLOAT;FLOAT;FLOAT;FLOAT
Node;AmplifyShaderEditor.ColorNode;12;-396.8989,-189.4002;Float;False;Property;_Color0;Color 0;3;0;0.716,0.716,0.716,0;COLOR;FLOAT;FLOAT;FLOAT;FLOAT
Node;AmplifyShaderEditor.SamplerNode;1;-459.2999,10.3999;Float;True;Property;_dirty_water;dirty_water;0;0;Assets/Swamp/Textures/dirty_water.tga;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;1.0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1.0;False;FLOAT4;FLOAT;FLOAT;FLOAT;FLOAT
Node;AmplifyShaderEditor.SurfaceDepthNode;6;-661.8989,288.5998;Float;False;0;FLOAT
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;11;-114.8989,9.599762;Float;False;0;COLOR;0.0;False;1;FLOAT4;0,0,0,0;False;FLOAT4
Node;AmplifyShaderEditor.RangedFloatNode;5;-493.8989,375.5998;Float;False;Property;_wateropacity;water opacity;2;0;0;0;1;FLOAT
Node;AmplifyShaderEditor.ScreenDepthNode;7;-484.8989,228.5998;Float;False;1;0;FLOAT4;0,0,0,0;False;FLOAT
Node;AmplifyShaderEditor.RangedFloatNode;15;-207.8989,369.5998;Float;False;Constant;_Float0;Float 0;3;0;0.5;0;0;FLOAT
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;85,6;Float;False;True;2;Float;ASEMaterialInspector;Standard;Custom/Water;False;False;False;False;True;True;True;True;True;False;False;False;Back;0;0;False;0;0;Custom;0.47;True;False;0;False;Transparent;Geometry;All;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;False;0;255;255;0;0;0;0;False;0;4;10;25;False;0.5;False;2;SrcAlpha;OneMinusSrcAlpha;0;Zero;Zero;OFF;Add;44;False;0;0,0,0,0;VertexOffset;False;Cylindrical;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0.0;False;4;FLOAT;0.0;False;5;FLOAT;0.0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0.0;False;9;FLOAT;0.0;False;10;OBJECT;0.0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;13;OBJECT;0.0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False
WireConnection;2;0;4;0
WireConnection;1;1;2;0
WireConnection;11;0;12;0
WireConnection;11;1;1;0
WireConnection;0;2;11;0
ASEEND*/
//CHKSM=6B6A4E5DAEE267FB72859BA2CE6E8D524086B5F4