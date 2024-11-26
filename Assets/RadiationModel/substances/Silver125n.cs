using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver125n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver125n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 124.93235d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver125()), new(0.324016d, new GammaParticle(102900.0, 0.01205)), new(0.47340000000000004d, new GammaParticle(669800.0, 0.00185)), new(0.38398000000000004d, new GammaParticle(684200.0, 0.00181)), new(0.526d, new GammaParticle(714300.0, 0.00174)), new(0.4208d, new GammaParticle(728300.0, 0.0017)), new(0.072588d, new GammaParticle(764800.0, 0.00162)), new(0.028929999999999997d, new GammaParticle(786900.0, 0.00158)), new(0.022921923939389643d, new GammaParticle(3218.0, 0.38528)), new(0.0770831251774483d, new GammaParticle(21990.0, 0.05638)), new(0.14530278073034553d, new GammaParticle(22163.0, 0.05594)), new(0.040252985524196074d, new GammaParticle(25030.0, 0.04953)), new(0.04725700500540619d, new GammaParticle(25211.0, 0.04918)), new(0.007004019481210116d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    