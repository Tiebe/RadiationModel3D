using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium166";
        public override double halfLife { get; } = 96566.4d;
        public override double atomicWeight { get; } = 165.93229d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium166() }, { 1.0d, new BetaParticle(-1, 926899.99999) }, { 0.0656464d, new GammaParticle(80576.0, 0.01539) }, { 1.5674e-05d, new GammaParticle(184400.0, 0.00672) }, { 3.4113999999999996e-06d, new GammaParticle(520800.0, 0.00238) }, { 0.00019085399999999999d, new GammaParticle(674188.0, 0.00184) }, { 0.00013737799999999998d, new GammaParticle(705334.0, 0.00176) }, { 0.0001185692d, new GammaParticle(785890.0, 0.00158) }, { 1.53052e-05d, new GammaParticle(1263010.0, 0.00098) }, { 0.00922d, new GammaParticle(1379437.0, 0.0009) }, { 1.0510800000000001e-05d, new GammaParticle(1447520.0, 0.00086) }, { 8.9434e-07d, new GammaParticle(1528230.0, 0.00081) }, { 0.0018246380000000002d, new GammaParticle(1581834.0, 0.00078) }, { 0.001191224d, new GammaParticle(1662439.0, 0.00075) }, { 0.000261848d, new GammaParticle(1749836.0, 0.00071) }, { 8.03062e-05d, new GammaParticle(1830419.0, 0.00068) }, { 0.0753025253038933d, new GammaParticle(7933.0, 0.15629) }, { 0.029514799446074685d, new GammaParticle(48222.0, 0.02571) }, { 0.052386935474040976d, new GammaParticle(49128.0, 0.02524) }, { 0.017023860615538327d, new GammaParticle(55779.0, 0.02223) }, { 0.021450064375578292d, new GammaParticle(56399.0, 0.02198) }, { 0.004426203760039965d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    