// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BlankProjectTestEditorTarget : TargetRules
{
	public BlankProjectTestEditorTarget( TargetInfo Target)
	{
		Type = TargetType.Editor;
	}
    public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.Add("BlankProjectTest");
	}
}
