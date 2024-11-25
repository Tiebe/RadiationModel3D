using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium129";
        public override double halfLife { get; } = 115416.0d;
        public override double atomicWeight { get; } = 128.90607d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine129() }, { 1.0d, new BetaParticle(1, 504000.0) }, { 0.029682d, new GammaParticle(39578.0, 0.03133) }, { 2.448e-05d, new GammaParticle(89790.0, 0.01381) }, { 0.006517800000000001d, new GammaParticle(93329.0, 0.01328) }, { 0.0026928000000000004d, new GammaParticle(177036.0, 0.007) }, { 0.0027234000000000004d, new GammaParticle(266820.0, 0.00465) }, { 0.0021267d, new GammaParticle(270352.0, 0.00459) }, { 0.0132192d, new GammaParticle(278614.0, 0.00445) }, { 0.0024174d, new GammaParticle(282131.0, 0.00439) }, { 3.06e-06d, new GammaParticle(302600.0, 0.0041) }, { 0.02448d, new GammaParticle(318180.0, 0.0039) }, { 9.180000000000001e-05d, new GammaParticle(321700.0, 0.00385) }, { 0.0007038d, new GammaParticle(321700.0, 0.00385) }, { 5.8139999999999996e-05d, new GammaParticle(357520.0, 0.00347) }, { 0.306d, new GammaParticle(371918.0, 0.00333) }, { 0.0001224d, new GammaParticle(373360.0, 0.00332) }, { 0.22307400000000002d, new GammaParticle(411490.0, 0.00301) }, { 0.00011322d, new GammaParticle(492780.0, 0.00252) }, { 9.486e-05d, new GammaParticle(533100.0, 0.00233) }, { 0.00021114000000000001d, new GammaParticle(534546.0, 0.00232) }, { 0.033965999999999996d, new GammaParticle(548945.0, 0.00226) }, { 1.53e-05d, new GammaParticle(572730.0, 0.00216) }, { 9.18e-06d, new GammaParticle(582600.0, 0.00213) }, { 4.59e-06d, new GammaParticle(585000.0, 0.00212) }, { 0.00012852d, new GammaParticle(586110.0, 0.00212) }, { 0.0060282d, new GammaParticle(588549.0, 0.00211) }, { 0.00028152d, new GammaParticle(624312.0, 0.00199) }, { 1.7136e-05d, new GammaParticle(627880.0, 0.00197) }, { 0.0003213d, new GammaParticle(864740.0, 0.00143) }, { 8.262e-05d, new GammaParticle(904310.0, 0.00137) }, { 0.0022001399999999997d, new GammaParticle(906425.0, 0.00137) }, { 0.00069462d, new GammaParticle(946046.0, 0.00131) }, { 5.7999999999999994e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.11828829263686093d, new GammaParticle(4540.0, 0.27309) }, { 0.2953479505640934d, new GammaParticle(29458.0, 0.04209) }, { 0.5471432948575276d, new GammaParticle(29778.0, 0.04164) }, { 0.15861465437670808d, new GammaParticle(33726.0, 0.03676) }, { 0.1960477128096112d, new GammaParticle(34030.0, 0.03643) }, { 0.03743305843290311d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    