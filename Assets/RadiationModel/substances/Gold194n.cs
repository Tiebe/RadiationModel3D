using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold194n : RadioactiveSubstance
    {
        public override string name { get; } = "Gold194n";
        public override double halfLife { get; } = 0.42d;
        public override double atomicWeight { get; } = 193.96593d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold194()), new(0.006d, new GammaParticle(33600.0, 0.0369)), new(0.00101d, new GammaParticle(69000.0, 0.01797)), new(0.273d, new GammaParticle(128570.0, 0.00964)), new(0.175d, new GammaParticle(137170.0, 0.00904)), new(0.10099999999999999d, new GammaParticle(162220.0, 0.00764)), new(0.276d, new GammaParticle(170780.0, 0.00726)), new(0.650982394608d, new GammaParticle(11419.0, 0.10858)), new(0.15093857142263772d, new GammaParticle(66991.0, 0.01851)), new(0.25696045526496036d, new GammaParticle(68806.0, 0.01802)), new(0.0867062322051217d, new GammaParticle(78048.0, 0.01589)), new(0.11176433331240189d, new GammaParticle(78983.0, 0.0157)), new(0.025058101107280174d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    