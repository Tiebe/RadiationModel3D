using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead206m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead206m";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 205.97683d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead206()), new(0.00098d, new GammaParticle(202440.0, 0.00612)), new(0.0006174d, new GammaParticle(313660.0, 0.00395)), new(0.2842d, new GammaParticle(343510.0, 0.00361)), new(0.9114d, new GammaParticle(516180.0, 0.0024)), new(0.294d, new GammaParticle(537470.0, 0.00231)), new(0.0032340000000000003d, new GammaParticle(657180.0, 0.00189)), new(0.98d, new GammaParticle(803060.0, 0.00154)), new(0.6664d, new GammaParticle(880980.0, 0.00141)), new(0.0004704d, new GammaParticle(1194680.0, 0.00104)), new(0.06364317753828541d, new GammaParticle(12522.0, 0.09901)), new(0.041518373821667856d, new GammaParticle(72805.0, 0.01703)), new(0.06977877953221488d, new GammaParticle(74970.0, 0.01654)), new(0.023849390004403444d, new GammaParticle(84986.0, 0.01459)), new(0.03105190578573328d, new GammaParticle(86022.0, 0.01441)), new(0.00720251578132984d, new GammaParticle(87301.0, 0.0142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    