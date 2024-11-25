using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc60 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc60";
        public override double halfLife { get; } = 142.8d;
        public override double atomicWeight { get; } = 59.94184d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel60() }, { 1.0d, new BetaParticle(1, 5149350.0) }, { 0.256d, new GammaParticle(61400.0, 0.02019) }, { 0.10880000000000001d, new GammaParticle(273400.0, 0.00453) }, { 0.08960000000000001d, new GammaParticle(334400.0, 0.00371) }, { 0.032d, new GammaParticle(364600.0, 0.0034) }, { 0.02624d, new GammaParticle(572400.0, 0.00217) }, { 0.64d, new GammaParticle(670300.0, 0.00185) }, { 0.01024d, new GammaParticle(947000.0, 0.00131) }, { 1.96d, new GammaParticle(511000.0, 0.00243) }, { 0.00115d, new GammaParticle(952.0, 1.30236) }, { 0.011000000000000001d, new GammaParticle(8028.0, 0.15444) }, { 0.021d, new GammaParticle(8048.0, 0.15406) }, { 0.0045000000000000005d, new GammaParticle(8940.0, 0.13868) }, { 0.0045000000000000005d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    