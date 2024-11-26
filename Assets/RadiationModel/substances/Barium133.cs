using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium133";
        public override double halfLife { get; } = 332957125.95792d;
        public override double atomicWeight { get; } = 132.90601d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium133()), new(0.021407250000000003d, new GammaParticle(53162.2, 0.02332)), new(0.02649535d, new GammaParticle(79614.2, 0.01557)), new(0.3294855d, new GammaParticle(80997.9, 0.01531)), new(0.006378740000000001d, new GammaParticle(160612.0, 0.00772)), new(0.00452965d, new GammaParticle(223236.8, 0.00555)), new(0.0716057d, new GammaParticle(276398.9, 0.00449)), new(0.18335775d, new GammaParticle(302850.8, 0.00409)), new(0.6204999999999999d, new GammaParticle(356012.9, 0.00348)), new(0.08941405d, new GammaParticle(383848.5, 0.00323)), new(0.153d, new GammaParticle(4749.0, 0.26107)), new(0.326d, new GammaParticle(30625.0, 0.04048)), new(0.602d, new GammaParticle(30973.0, 0.04003)), new(0.17600000000000002d, new GammaParticle(35089.0, 0.03533)), new(0.21899999999999997d, new GammaParticle(35414.0, 0.03501)), new(0.0429d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    