using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium115";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 114.91366d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver115()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0010639999999999998d, new GammaParticle(48300.0, 0.02567)), new(0.002888d, new GammaParticle(92700.0, 0.01337)), new(0.01102d, new GammaParticle(110400.0, 0.01123)), new(0.010107999999999999d, new GammaParticle(140600.0, 0.00882)), new(0.000988d, new GammaParticle(158700.0, 0.00781)), new(0.006232d, new GammaParticle(200700.0, 0.00618)), new(0.027360000000000002d, new GammaParticle(247530.0, 0.00501)), new(0.000988d, new GammaParticle(262700.0, 0.00472)), new(0.004712d, new GammaParticle(293560.0, 0.00422)), new(0.074936d, new GammaParticle(303870.0, 0.00408)), new(0.076d, new GammaParticle(342710.0, 0.00362)), new(0.03952d, new GammaParticle(372920.0, 0.00332)), new(0.06308d, new GammaParticle(396560.0, 0.00313)), new(0.005776d, new GammaParticle(430900.0, 0.00288)), new(0.05928d, new GammaParticle(556320.0, 0.00223)), new(0.001d, new GammaParticle(3218.0, 0.38528)), new(0.0036d, new GammaParticle(21990.0, 0.05638)), new(0.0067d, new GammaParticle(22163.0, 0.05594)), new(0.0019d, new GammaParticle(25030.0, 0.04953)), new(0.0022d, new GammaParticle(25211.0, 0.04918)), new(0.00032d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    