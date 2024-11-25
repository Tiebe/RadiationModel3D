using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium141m";
        public override double halfLife { get; } = 62.0d;
        public override double atomicWeight { get; } = 140.91043d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium141() }, { 0.9159d, new GammaParticle(756510.0, 0.00164) }, { 0.0099845032519995d, new GammaParticle(5870.0, 0.21122) }, { 0.01767366752966628d, new GammaParticle(36848.0, 0.03365) }, { 0.03218660996114784d, new GammaParticle(37362.0, 0.03318) }, { 0.00988479009603093d, new GammaParticle(42380.0, 0.02926) }, { 0.012425181150710878d, new GammaParticle(42810.0, 0.02896) }, { 0.0025403910546799493d, new GammaParticle(43335.0, 0.02861) } } },
            { 0.0005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium141() }, { 1.0d, new BetaParticle(1, 998050.0) }, { 5.52e-07d, new GammaParticle(511000.0, 0.00243) }, { 2.3999999999999997e-05d, new GammaParticle(5637.0, 0.21995) }, { 4e-05d, new GammaParticle(35551.0, 0.03488) }, { 8e-05d, new GammaParticle(36027.0, 0.03441) }, { 2e-05d, new GammaParticle(40857.0, 0.03035) }, { 3e-05d, new GammaParticle(41266.0, 0.03005) }, { 5.999999999999999e-06d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    