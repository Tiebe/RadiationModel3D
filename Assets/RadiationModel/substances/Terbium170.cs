using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium170";
        public override double halfLife { get; } = 0.96d;
        public override double atomicWeight { get; } = 169.94985d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Dysprosium170()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.092d, new GammaParticle(71450.0, 0.01735)), new(0.151d, new GammaParticle(165840.0, 0.00748)), new(0.10400000000000001d, new GammaParticle(687720.0, 0.0018)), new(0.74d, new GammaParticle(789930.0, 0.00157)), new(0.059000000000000004d, new GammaParticle(853700.0, 0.00145)), new(0.09699999999999999d, new GammaParticle(920200.0, 0.00135)), new(0.027999999999999997d, new GammaParticle(992100.0, 0.00125)), new(0.08d, new GammaParticle(1104500.0, 0.00112)), new(0.16d, new GammaParticle(1169310.0, 0.00106)), new(0.15139180187824d, new GammaParticle(7384.0, 0.16791)), new(0.06699742346499388d, new GammaParticle(45207.0, 0.02743)), new(0.11972377316832357d, new GammaParticle(45998.0, 0.02695)), new(0.03844085587831949d, new GammaParticle(52220.0, 0.02374)), new(0.04843547840668255d, new GammaParticle(52791.0, 0.02349)), new(0.009994622528363067d, new GammaParticle(53478.0, 0.02318)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    