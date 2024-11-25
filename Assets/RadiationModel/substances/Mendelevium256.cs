using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium256";
        public override double halfLife { get; } = 4662.0d;
        public override double atomicWeight { get; } = 256.09389d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9079999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium256() }, { 0.00106d, new GammaParticle(111600.0, 0.01111) }, { 0.0072d, new GammaParticle(565800.0, 0.00219) }, { 0.0118d, new GammaParticle(600800.0, 0.00206) }, { 0.016d, new GammaParticle(634100.0, 0.00196) }, { 0.061d, new GammaParticle(634100.0, 0.00196) }, { 0.071d, new GammaParticle(644000.0, 0.00193) }, { 0.031d, new GammaParticle(677300.0, 0.00183) }, { 0.015d, new GammaParticle(680000.0, 0.00182) }, { 0.065d, new GammaParticle(682100.0, 0.00182) }, { 0.048d, new GammaParticle(692000.0, 0.00179) }, { 0.0177d, new GammaParticle(723000.0, 0.00171) }, { 0.0092d, new GammaParticle(1200600.0, 0.00103) }, { 0.0098d, new GammaParticle(1278000.0, 0.00097) }, { 0.0216d, new GammaParticle(1312300.0, 0.00094) }, { 0.0235d, new GammaParticle(1326100.0, 0.00093) }, { 0.0235d, new GammaParticle(1326100.0, 0.00093) }, { 0.0216d, new GammaParticle(1357100.0, 0.00091) }, { 0.025d, new GammaParticle(1374100.0, 0.0009) }, { 0.0024d, new GammaParticle(511000.0, 0.00243) }, { 0.418d, new GammaParticle(20618.0, 0.06013) }, { 0.19899999999999998d, new GammaParticle(115320.0, 0.01075) }, { 0.305d, new GammaParticle(121090.0, 0.01024) }, { 0.11900000000000001d, new GammaParticle(136318.0, 0.0091) }, { 0.162d, new GammaParticle(138067.0, 0.00898) }, { 0.0429d, new GammaParticle(140406.0, 0.00883) } } },
            { 0.092d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium252() }, { 1.0d, new AlphaParticle(8767002.09) } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    