using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold202 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold202";
        public override double halfLife { get; } = 28.4d;
        public override double atomicWeight { get; } = 201.97386d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury202() }, { 1.0d, new BetaParticle(-1, 1496150.00001) }, { 0.0085d, new GammaParticle(388000.0, 0.0032) }, { 0.092d, new GammaParticle(439560.0, 0.00282) }, { 0.016d, new GammaParticle(520130.0, 0.00238) }, { 0.03d, new GammaParticle(654900.0, 0.00189) }, { 0.004699999999999999d, new GammaParticle(786000.0, 0.00158) }, { 0.017d, new GammaParticle(908390.0, 0.00136) }, { 0.0022d, new GammaParticle(960100.0, 0.00129) }, { 0.0069d, new GammaParticle(971850.0, 0.00128) }, { 0.021d, new GammaParticle(1125200.0, 0.0011) }, { 0.019d, new GammaParticle(1204100.0, 0.00103) }, { 0.021d, new GammaParticle(1306370.0, 0.00095) }, { 0.00065d, new GammaParticle(1746400.0, 0.00071) }, { 0.00095d, new GammaParticle(1851700.0, 0.00067) }, { 0.00097d, new GammaParticle(1959000.0, 0.00063) }, { 0.00163581181584d, new GammaParticle(11777.0, 0.10528) }, { 0.001191106165921202d, new GammaParticle(68894.0, 0.018) }, { 0.002019166241602309d, new GammaParticle(70820.0, 0.01751) }, { 0.0006852553630908656d, new GammaParticle(80316.0, 0.01544) }, { 0.0008860351844764891d, new GammaParticle(81285.0, 0.01525) }, { 0.0002007798213856236d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    