using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FusionFuryGame.ChallengeManager;

namespace FusionFuryGame
{
    public class LevelManager : Singlton<LevelManager>
    {
        public GenericDictionary<int, ChallengeType> levelChallengeMapping = new GenericDictionary<int, ChallengeType>();
        public int currentLevel;
        private void Start()
        {
            StartChallengeForCurrentLevel(currentLevel);
        }
        public void StartChallengeForCurrentLevel(int currentLevel)
        {
            if (levelChallengeMapping.TryGetValue(currentLevel, out ChallengeType challengeType))
            {
                // Start the challenge associated with the current level
                ChallengeManager.Instance.StartChallenge(challengeType);
            }
            else
            {
                Debug.LogError($"No challenge mapped for Level {currentLevel}");
            }
        }
       
    }
}