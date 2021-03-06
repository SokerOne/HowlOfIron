// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HowlOfIron : ModuleRules
{
	public HowlOfIron(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "GameplayTags", "GameplayTasks", "GameplayAbilities" });
	}
}
