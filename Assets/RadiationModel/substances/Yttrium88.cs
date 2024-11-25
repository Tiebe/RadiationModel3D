using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium88";
        public override double halfLife { get; } = 9212486.4d;
        public override double atomicWeight { get; } = 87.9095d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium88() }, { 1.0d, new BetaParticle(1, -845000.0) }, { 0.000654984d, new GammaParticle(850600.0, 0.00146) }, { 0.9368255999999999d, new GammaParticle(898042.0, 0.00138) }, { 0.00020840399999999998d, new GammaParticle(1382200.0, 0.0009) }, { 0.9924d, new GammaParticle(1836063.0, 0.00068) }, { 0.00714528d, new GammaParticle(2734000.0, 0.00045) }, { 7.04604e-05d, new GammaParticle(3219700.0, 0.00039) }, { 0.0042d, new GammaParticle(511000.0, 0.00243) }, { 0.027886322650522932d, new GammaParticle(1890.0, 0.656) }, { 0.175346315003416d, new GammaParticle(14098.0, 0.08794) }, { 0.33688052834469934d, new GammaParticle(14165.0, 0.08753) }, { 0.08318019978263644d, new GammaParticle(15898.0, 0.07799) }, { 0.09399362575437915d, new GammaParticle(15955.0, 0.07771) }, { 0.010813425971742736d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    