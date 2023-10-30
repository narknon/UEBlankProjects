// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BlankProjectTestTarget : TargetRules
{
	public BlankProjectTestTarget( TargetInfo Target)
	{
		Type = TargetType.Game;
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
