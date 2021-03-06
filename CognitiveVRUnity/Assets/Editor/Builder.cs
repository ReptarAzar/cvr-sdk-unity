﻿using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class Builder 
{
	static string[] cognitivevr_files = new string[] {
		"Assets/Plugins/CognitiveVR.dll",
		"Assets/Plugins/CognitiveVR",
	};

	[MenuItem("CognitiveVR/Export BubblePop Package")]
	static void MakeBPPackage()
	{
		List<string> game_files = new List<string> {
            "Assets/Samples/BubblePop/Assets/BubblePop.unity",
            "Assets/Samples/BubblePop/Assets/Resources",
            "Assets/Samples/BubblePop/Assets/Scripts",
		};
		game_files.AddRange(cognitivevr_files);

		System.IO.Directory.CreateDirectory(Application.dataPath + "/../../dist");
		AssetDatabase.ExportPackage(game_files.ToArray(), "../dist/BubblePop.unitypackage", ExportPackageOptions.Recurse);
	}

	[MenuItem("CognitiveVR/Export CognitiveVR Package")]
	static void MakeCognitiveVRPackage()
	{
		System.IO.Directory.CreateDirectory(Application.dataPath + "/../../dist");
		AssetDatabase.ExportPackage(cognitivevr_files, "../dist/CognitiveVR.unitypackage", ExportPackageOptions.Recurse);
	}
}
