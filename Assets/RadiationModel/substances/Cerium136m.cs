using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium136m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 135.91045d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium136()), new(0.366d, new GammaParticle(104900.0, 0.01182)), new(0.016d, new GammaParticle(328500.0, 0.00377)), new(1.0d, new GammaParticle(552100.0, 0.00225)), new(0.63d, new GammaParticle(623300.0, 0.00199)), new(0.019d, new GammaParticle(664200.0, 0.00187)), new(0.012d, new GammaParticle(683100.0, 0.00182)), new(1.0d, new GammaParticle(762300.0, 0.00163)), new(0.37d, new GammaParticle(775700.0, 0.0016)), new(0.37d, new GammaParticle(900000.0, 0.00138)), new(0.63d, new GammaParticle(1052400.0, 0.00118)), new(0.068580709789d, new GammaParticle(5410.0, 0.22918)), new(0.10395404372285358d, new GammaParticle(34279.0, 0.03617)), new(0.1903920214704278d, new GammaParticle(34720.0, 0.03571)), new(0.05734349579483144d, new GammaParticle(39366.0, 0.0315)), new(0.07190874372671863d, new GammaParticle(39753.0, 0.03119)), new(0.014565247931887187d, new GammaParticle(40229.0, 0.03082)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    