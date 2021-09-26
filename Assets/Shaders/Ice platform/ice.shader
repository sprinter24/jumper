// Shader created with Shader Forge v1.42 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Enhanced by Antoine Guillon / Arkham Development - http://www.arkham-development.com/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.42;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33516,y:32671,varname:node_9361,prsc:2|diff-7061-RGB,diffpow-9990-OUT,spec-5086-OUT,gloss-9990-OUT,normal-5034-OUT,emission-5245-OUT,alpha-9211-OUT,refract-1444-OUT;n:type:ShaderForge.SFN_Color,id:7061,x:33446,y:32228,ptovrint:False,ptlb:color,ptin:_color,varname:node_7061,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.003575802,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Fresnel,id:3200,x:32741,y:32657,varname:node_3200,prsc:2|EXP-4785-OUT;n:type:ShaderForge.SFN_Vector1,id:4785,x:32578,y:32619,varname:node_4785,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:8372,x:32934,y:32657,varname:node_8372,prsc:2|A-3200-OUT,B-6275-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6275,x:32741,y:32794,ptovrint:False,ptlb:Fresnel strench,ptin:_Fresnelstrench,varname:node_6275,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Multiply,id:6330,x:33042,y:32803,varname:node_6330,prsc:2|A-8372-OUT,B-8225-RGB,C-3081-RGB;n:type:ShaderForge.SFN_Cubemap,id:8225,x:32814,y:32896,ptovrint:False,ptlb:ice cubemap,ptin:_icecubemap,varname:node_8225,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,cube:70bd7bf97a5392d48afc80a51b97b9c8,pvfc:0;n:type:ShaderForge.SFN_Tex2d,id:3081,x:32917,y:33046,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_3081,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:86d67bb772292234e98f6f5c8a676bb9,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Clamp01,id:5245,x:33212,y:32803,varname:node_5245,prsc:2|IN-6330-OUT;n:type:ShaderForge.SFN_Slider,id:9211,x:33184,y:32981,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_9211,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3728553,max:1;n:type:ShaderForge.SFN_Tex2d,id:5391,x:32718,y:32400,ptovrint:False,ptlb:Normal map,ptin:_Normalmap,varname:node_5391,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a8ab47272f65797409346d5063bc3aec,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Multiply,id:2719,x:33006,y:32431,varname:node_2719,prsc:2|A-9365-OUT,B-5391-RGB;n:type:ShaderForge.SFN_Slider,id:9365,x:32579,y:32265,ptovrint:False,ptlb:distortion strench,ptin:_distortionstrench,varname:node_9365,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-2,cur:0.25,max:2;n:type:ShaderForge.SFN_ComponentMask,id:1444,x:33179,y:32431,varname:node_1444,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-2719-OUT;n:type:ShaderForge.SFN_Lerp,id:5034,x:33179,y:32303,varname:node_5034,prsc:2|A-2013-OUT,B-2719-OUT,T-1593-OUT;n:type:ShaderForge.SFN_Vector1,id:1593,x:32991,y:32337,varname:node_1593,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Vector3,id:2013,x:33006,y:32235,varname:node_2013,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_Vector1,id:9990,x:33342,y:32027,varname:node_9990,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:5086,x:33241,y:32110,varname:node_5086,prsc:2,v1:0.2;proporder:7061-6275-8225-3081-9211-5391-9365;pass:END;sub:END;*/

Shader "Shader Forge/ice" {
    Properties {
        _color ("color", Color) = (0.003575802,0,1,1)
        _Fresnelstrench ("Fresnel strench", Float ) = 2
        _icecubemap ("ice cubemap", Cube) = "_Skybox" {}
        _Texture ("Texture", 2D) = "white" {}
        _Opacity ("Opacity", Range(0, 1)) = 0.3728553
        _Normalmap ("Normal map", 2D) = "bump" {}
        _distortionstrench ("distortion strench", Range(-2, 2)) = 0.25
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #ifndef UNITY_PASS_FORWARDBASE
            #define UNITY_PASS_FORWARDBASE
            #endif //UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu switch vulkan 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _color;
            uniform float _Fresnelstrench;
            uniform samplerCUBE _icecubemap;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _Opacity;
            uniform sampler2D _Normalmap; uniform float4 _Normalmap_ST;
            uniform float _distortionstrench;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normalmap_var = UnpackNormal(tex2D(_Normalmap,TRANSFORM_TEX(i.uv0, _Normalmap)));
                float3 node_2719 = (_distortionstrench*_Normalmap_var.rgb);
                float3 normalLocal = lerp(float3(0,0,1),node_2719,0.1);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + node_2719.rg;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float node_9990 = 1.0;
                float gloss = node_9990;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_5086 = 0.2;
                float3 specularColor = float3(node_5086,node_5086,node_5086);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = pow(max( 0.0, NdotL), node_9990) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = _color.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(i.uv0, _Texture));
                float3 emissive = saturate(((pow(1.0-max(0,dot(normalDirection, viewDirection)),0.0)*_Fresnelstrench)*texCUBE(_icecubemap,viewReflectDirection).rgb*_Texture_var.rgb));
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,_Opacity),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #ifndef UNITY_PASS_FORWARDADD
            #define UNITY_PASS_FORWARDADD
            #endif //UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu switch vulkan 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _color;
            uniform float _Fresnelstrench;
            uniform samplerCUBE _icecubemap;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _Opacity;
            uniform sampler2D _Normalmap; uniform float4 _Normalmap_ST;
            uniform float _distortionstrench;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                UNITY_TRANSFER_LIGHTING(o, float2(0,0));
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normalmap_var = UnpackNormal(tex2D(_Normalmap,TRANSFORM_TEX(i.uv0, _Normalmap)));
                float3 node_2719 = (_distortionstrench*_Normalmap_var.rgb);
                float3 normalLocal = lerp(float3(0,0,1),node_2719,0.1);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + node_2719.rg;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                UNITY_LIGHT_ATTENUATION(attenuation, i, i.posWorld.xyz);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float node_9990 = 1.0;
                float gloss = node_9990;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_5086 = 0.2;
                float3 specularColor = float3(node_5086,node_5086,node_5086);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = pow(max( 0.0, NdotL), node_9990) * attenColor;
                float3 diffuseColor = _color.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * _Opacity,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
