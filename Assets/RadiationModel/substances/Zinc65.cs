using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc65 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc65";
        public override double halfLife { get; } = 21075552.0d;
        public override double atomicWeight { get; } = 64.92924d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel65() }, { 1.0d, new BetaParticle(1, -393100.0) }, { 2.5300000000000002e-05d, new GammaParticle(344950.0, 0.00359) }, { 2.68e-05d, new GammaParticle(770600.0, 0.00161) }, { 0.5004d, new GammaParticle(1115539.0, 0.00111) }, { 0.02842d, new GammaParticle(511000.0, 0.00243) }, { 0.012409209724619697d, new GammaParticle(952.0, 1.30236) }, { 0.11763989923311671d, new GammaParticle(8028.0, 0.15444) }, { 0.2291835169162609d, new GammaParticle(8048.0, 0.15406) }, { 0.048243137186378425d, new GammaParticle(8940.0, 0.13868) }, { 0.048243137186378425d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    