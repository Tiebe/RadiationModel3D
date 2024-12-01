using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton81 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton81";
        public override double halfLife { get; } = 7226536048181.568d;
        public override double atomicWeight { get; } = 80.91659d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine81()), new(0.00298d, new GammaParticle(275990.0, 0.00449)), new(0.021739523810389117d, new GammaParticle(1535.0, 0.80771)), new(0.15497693267641835d, new GammaParticle(11879.0, 0.10437)), new(0.29912552147542626d, new GammaParticle(11925.0, 0.10397)), new(0.07094823898417699d, new GammaParticle(13345.0, 0.09291)), new(0.07642544303375544d, new GammaParticle(13377.0, 0.09268)), new(0.005477204049578462d, new GammaParticle(13469.0, 0.09205)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    