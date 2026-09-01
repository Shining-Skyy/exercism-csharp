using Xunit.Sdk;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake , bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        var archer = !archerIsAwake;
        return archer && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        var dogDistractsWhileKnightWatches = petDogIsPresent && !archerIsAwake && knightIsAwake;
        var prisonerAwakeWithNoGuardsOrDog = !petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake;
        var allAsleepWithDogPresent = !knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent;
        var guardsAsleepPrisonerAwakeWithDog = !knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent;

        return dogDistractsWhileKnightWatches
            || prisonerAwakeWithNoGuardsOrDog
            || allAsleepWithDogPresent
            || guardsAsleepPrisonerAwakeWithDog;
    }
}