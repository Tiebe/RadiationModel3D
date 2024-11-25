using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium168";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 167.96158d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum168() }, { 1.0d, new BetaParticle(1, 6302000.0) }, { 0.924d, new GammaParticle(199300.0, 0.00622) }, { 0.01672d, new GammaParticle(297700.0, 0.00416) }, { 0.00616d, new GammaParticle(311900.0, 0.00398) }, { 0.00528d, new GammaParticle(314400.0, 0.00394) }, { 0.88d, new GammaParticle(363200.0, 0.00341) }, { 0.0132d, new GammaParticle(419800.0, 0.00295) }, { 0.57992d, new GammaParticle(479800.0, 0.00258) }, { 0.027280000000000002d, new GammaParticle(481900.0, 0.00257) }, { 0.04488d, new GammaParticle(494100.0, 0.00251) }, { 0.09768d, new GammaParticle(558200.0, 0.00222) }, { 0.0088d, new GammaParticle(581000.0, 0.00213) }, { 0.03168d, new GammaParticle(659500.0, 0.00188) }, { 0.05808d, new GammaParticle(716600.0, 0.00173) }, { 0.04136d, new GammaParticle(718800.0, 0.00172) }, { 0.03344d, new GammaParticle(792200.0, 0.00157) }, { 0.022000000000000002d, new GammaParticle(839700.0, 0.00148) }, { 0.00528d, new GammaParticle(868700.0, 0.00143) }, { 0.01056d, new GammaParticle(870900.0, 0.00142) }, { 0.045759999999999995d, new GammaParticle(918200.0, 0.00135) }, { 0.02464d, new GammaParticle(974000.0, 0.00127) }, { 0.043120000000000006d, new GammaParticle(1014800.0, 0.00122) }, { 0.06248d, new GammaParticle(1024500.0, 0.00121) }, { 0.01848d, new GammaParticle(1177400.0, 0.00105) }, { 0.01232d, new GammaParticle(1217700.0, 0.00102) }, { 0.046639999999999994d, new GammaParticle(1388000.0, 0.00089) }, { 0.022000000000000002d, new GammaParticle(1437800.0, 0.00086) }, { 1.714d, new GammaParticle(511000.0, 0.00243) }, { 0.11223597757622d, new GammaParticle(9740.0, 0.12729) }, { 0.08833291476117677d, new GammaParticle(57983.0, 0.02138) }, { 0.15343566920475382d, new GammaParticle(59320.0, 0.0209) }, { 0.0508586974119854d, new GammaParticle(67335.0, 0.01841) }, { 0.0647939805028694d, new GammaParticle(68117.0, 0.0182) }, { 0.013935283090883998d, new GammaParticle(69068.0, 0.01795) } } },
            { 5e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum164() }, { 1.0d, new AlphaParticle(6090002.09) } } },

        };
    }
}
    