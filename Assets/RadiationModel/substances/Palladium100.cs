using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium100";
        public override double halfLife { get; } = 313632.0d;
        public override double atomicWeight { get; } = 99.90852d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium100() }, { 0.000624d, new GammaParticle(15500.0, 0.07999) }, { 0.02548d, new GammaParticle(32660.0, 0.03796) }, { 0.0702d, new GammaParticle(42080.0, 0.02946) }, { 0.000416d, new GammaParticle(53520.0, 0.02317) }, { 0.002652d, new GammaParticle(61600.0, 0.02013) }, { 0.00078d, new GammaParticle(72520.0, 0.0171) }, { 0.47840000000000005d, new GammaParticle(74780.0, 0.01658) }, { 0.52d, new GammaParticle(84000.0, 0.01476) }, { 0.00026d, new GammaParticle(86370.0, 0.01436) }, { 0.000676d, new GammaParticle(119180.0, 0.0104) }, { 0.078d, new GammaParticle(126150.0, 0.00983) }, { 0.00182d, new GammaParticle(139920.0, 0.00886) }, { 0.003172d, new GammaParticle(151880.0, 0.00816) }, { 0.00031719999999999996d, new GammaParticle(154000.0, 0.00805) }, { 0.01664d, new GammaParticle(158870.0, 0.0078) }, { 0.087d, new GammaParticle(2892.0, 0.42871) }, { 0.358d, new GammaParticle(20073.0, 0.06177) }, { 0.68d, new GammaParticle(20215.0, 0.06133) }, { 0.184d, new GammaParticle(22806.0, 0.05436) }, { 0.214d, new GammaParticle(22957.0, 0.05401) }, { 0.0305d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    