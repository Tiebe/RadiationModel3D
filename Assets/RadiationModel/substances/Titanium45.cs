using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium45";
        public override double halfLife { get; } = 11088.0d;
        public override double atomicWeight { get; } = 44.95812d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium45() }, { 1.0d, new BetaParticle(1, 900950.0) }, { 3.3e-07d, new GammaParticle(12400.0, 0.09999) }, { 8e-08d, new GammaParticle(166400.0, 0.00745) }, { 5.7e-05d, new GammaParticle(364000.0, 0.00341) }, { 5.199999999999999e-06d, new GammaParticle(377100.0, 0.00329) }, { 0.000137d, new GammaParticle(425000.0, 0.00292) }, { 1.4e-05d, new GammaParticle(432000.0, 0.00287) }, { 1.1000000000000001e-05d, new GammaParticle(530000.0, 0.00234) }, { 9e-06d, new GammaParticle(543000.0, 0.00228) }, { 6.3e-05d, new GammaParticle(688900.0, 0.0018) }, { 5.1000000000000006e-05d, new GammaParticle(708200.0, 0.00175) }, { 0.00154d, new GammaParticle(719600.0, 0.00172) }, { 5.7e-05d, new GammaParticle(942000.0, 0.00132) }, { 3e-05d, new GammaParticle(961600.0, 0.00129) }, { 5.7999999999999994e-05d, new GammaParticle(974000.0, 0.00127) }, { 4.7999999999999994e-05d, new GammaParticle(1032100.0, 0.0012) }, { 0.000118d, new GammaParticle(1236500.0, 0.001) }, { 0.0008500000000000001d, new GammaParticle(1408100.0, 0.00088) }, { 0.000407d, new GammaParticle(1660900.0, 0.00075) }, { 5.7e-07d, new GammaParticle(1789000.0, 0.00069) }, { 4.1e-07d, new GammaParticle(1801000.0, 0.00069) }, { 1.6963803999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.00062d, new GammaParticle(422.0, 2.93801) }, { 0.00792d, new GammaParticle(4086.0, 0.30344) }, { 0.015600000000000001d, new GammaParticle(4091.0, 0.30307) }, { 0.00311d, new GammaParticle(4474.0, 0.27712) }, { 0.00311d, new GammaParticle(4474.0, 0.27712) } } },

        };
    }
}
    