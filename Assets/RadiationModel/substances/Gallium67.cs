using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium67 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium67";
        public override double halfLife { get; } = 281810.88d;
        public override double atomicWeight { get; } = 66.9282d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc67() }, { 0.0311d, new GammaParticle(91265.0, 0.01359) }, { 0.3881d, new GammaParticle(93310.0, 0.01329) }, { 0.2141d, new GammaParticle(184576.0, 0.00672) }, { 0.0246d, new GammaParticle(208950.0, 0.00593) }, { 0.1664d, new GammaParticle(300217.0, 0.00413) }, { 0.045599999999999995d, new GammaParticle(393527.0, 0.00315) }, { 0.000684d, new GammaParticle(494166.0, 0.00251) }, { 0.000105d, new GammaParticle(703106.0, 0.00176) }, { 0.00054d, new GammaParticle(794381.0, 0.00156) }, { 0.00148d, new GammaParticle(887688.0, 0.0014) }, { 0.01847994740150832d, new GammaParticle(1035.0, 1.19791) }, { 0.17176652561133213d, new GammaParticle(8616.0, 0.1439) }, { 0.334046140823283d, new GammaParticle(8639.0, 0.14352) }, { 0.07167365483378496d, new GammaParticle(9610.0, 0.12902) }, { 0.07167365483378496d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    