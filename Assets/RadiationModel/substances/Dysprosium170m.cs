using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium170m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 169.9441d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium170()), new(0.092d, new GammaParticle(71450.0, 0.01735)), new(0.58d, new GammaParticle(165840.0, 0.00748)), new(0.032d, new GammaParticle(255000.0, 0.00486)), new(0.09d, new GammaParticle(256900.0, 0.00483)), new(0.3d, new GammaParticle(386330.0, 0.00321)), new(0.44d, new GammaParticle(496640.0, 0.0025)), new(0.13699999999999998d, new GammaParticle(527280.0, 0.00235)), new(0.044000000000000004d, new GammaParticle(621800.0, 0.00199)), new(0.053d, new GammaParticle(764000.0, 0.00162)), new(0.061d, new GammaParticle(789930.0, 0.00157)), new(0.033d, new GammaParticle(894500.0, 0.00139)), new(0.29d, new GammaParticle(909790.0, 0.00136)), new(0.332d, new GammaParticle(1020500.0, 0.00121)), new(0.028999999999999998d, new GammaParticle(1075680.0, 0.00115)), new(0.02d, new GammaParticle(1148900.0, 0.00108)), new(0.021d, new GammaParticle(1406000.0, 0.00088)), new(0.19d, new GammaParticle(7384.0, 0.16791)), new(0.106d, new GammaParticle(45207.0, 0.02743)), new(0.19d, new GammaParticle(45998.0, 0.02695)), new(0.061d, new GammaParticle(52220.0, 0.02374)), new(0.076d, new GammaParticle(52791.0, 0.02349)), new(0.015700000000000002d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    