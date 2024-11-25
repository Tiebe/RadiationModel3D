using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium239";
        public override double halfLife { get; } = 9720.0d;
        public override double atomicWeight { get; } = 239.05491d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium239() }, { 0.1188d, new GammaParticle(146400.0, 0.00847) }, { 0.36d, new GammaParticle(188000.0, 0.00659) }, { 0.0284973064416d, new GammaParticle(18078.0, 0.06858) }, { 0.015320752408183815d, new GammaParticle(102031.0, 0.01215) }, { 0.02411957243101986d, new GammaParticle(106468.0, 0.01165) }, { 0.008939806963552833d, new GammaParticle(120157.0, 0.01032) }, { 0.012068739400796325d, new GammaParticle(121688.0, 0.01019) }, { 0.003128932437243491d, new GammaParticle(123677.0, 0.01002) } } },
            { 1e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium235() }, { 1.0d, new AlphaParticle(7565002.09) } } },

        };
    }
}
    