using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium82";
        public override double halfLife { get; } = 8.3d;
        public override double atomicWeight { get; } = 81.92693d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium82() }, { 1.0d, new BetaParticle(1, 4062000.0) }, { 0.25d, new GammaParticle(573400.0, 0.00216) }, { 0.011000000000000001d, new GammaParticle(601900.0, 0.00206) }, { 0.00125d, new GammaParticle(688900.0, 0.0018) }, { 0.02125d, new GammaParticle(737300.0, 0.00168) }, { 0.0022500000000000003d, new GammaParticle(1175900.0, 0.00105) }, { 0.004d, new GammaParticle(1291000.0, 0.00096) }, { 0.00125d, new GammaParticle(1865300.0, 0.00066) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 0.00016795608512000003d, new GammaParticle(1890.0, 0.656) }, { 0.001059075882333083d, new GammaParticle(14098.0, 0.08794) }, { 0.002034727919948286d, new GammaParticle(14165.0, 0.08753) }, { 0.0005024008829368418d, new GammaParticle(15898.0, 0.07799) }, { 0.0005677129977186311d, new GammaParticle(15955.0, 0.07771) }, { 6.531211478178943e-05d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    