using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold187m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold187m";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 186.96467d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold187()), new(0.0083d, new GammaParticle(101100.0, 0.01226)), new(0.2506878562608d, new GammaParticle(11419.0, 0.10858)), new(0.002145394672211642d, new GammaParticle(66991.0, 0.01851)), new(0.0036523572901117495d, new GammaParticle(68806.0, 0.01802)), new(0.0012324158554512096d, new GammaParticle(78048.0, 0.01589)), new(0.001588584037676609d, new GammaParticle(78983.0, 0.0157)), new(0.0003561681822253996d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    