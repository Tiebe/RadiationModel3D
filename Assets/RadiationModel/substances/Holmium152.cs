using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium152";
        public override double halfLife { get; } = 161.8d;
        public override double atomicWeight { get; } = 151.93172d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium152() }, { 1.0d, new BetaParticle(1, 3557500.0) }, { 0.0017599999999999998d, new GammaParticle(437000.0, 0.00284) }, { 0.034300000000000004d, new GammaParticle(489500.0, 0.00253) }, { 0.084d, new GammaParticle(613000.0, 0.00202) }, { 0.78d, new GammaParticle(613900.0, 0.00202) }, { 0.14d, new GammaParticle(647200.0, 0.00192) }, { 0.096d, new GammaParticle(700000.0, 0.00177) }, { 0.0554d, new GammaParticle(839100.0, 0.00148) }, { 0.0141d, new GammaParticle(1136800.0, 0.00109) }, { 0.015d, new GammaParticle(1226800.0, 0.00101) }, { 0.0414d, new GammaParticle(1313700.0, 0.00094) }, { 0.0132d, new GammaParticle(1448200.0, 0.00086) }, { 0.0176d, new GammaParticle(1452600.0, 0.00085) }, { 0.023799999999999998d, new GammaParticle(1697900.0, 0.00073) }, { 1.796d, new GammaParticle(511000.0, 0.00243) }, { 0.021d, new GammaParticle(7384.0, 0.16791) }, { 0.03d, new GammaParticle(45207.0, 0.02743) }, { 0.05d, new GammaParticle(45998.0, 0.02695) }, { 0.017d, new GammaParticle(52220.0, 0.02374) }, { 0.021d, new GammaParticle(52791.0, 0.02349) }, { 0.004d, new GammaParticle(53478.0, 0.02318) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium148() }, { 1.0d, new AlphaParticle(5529002.09) } } },

        };
    }
}
    