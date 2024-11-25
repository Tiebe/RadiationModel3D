using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium153";
        public override double halfLife { get; } = 20770560.0d;
        public override double atomicWeight { get; } = 152.92176d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium153() }, { 0.000183d, new GammaParticle(14063.83, 0.08816) }, { 7e-07d, new GammaParticle(19812.96, 0.06258) }, { 0.000225d, new GammaParticle(21200.0, 0.05848) }, { 0.024540000000000003d, new GammaParticle(69673.0, 0.0178) }, { 0.0008100000000000001d, new GammaParticle(75422.13, 0.01644) }, { 0.0020280000000000003d, new GammaParticle(83367.17, 0.01487) }, { 0.0008100000000000001d, new GammaParticle(89485.95, 0.01386) }, { 0.3d, new GammaParticle(97431.0, 0.01273) }, { 0.2205d, new GammaParticle(103180.12, 0.01202) }, { 0.0003912d, new GammaParticle(172853.07, 0.00717) }, { 0.22699999999999998d, new GammaParticle(6603.0, 0.18777) }, { 0.34700000000000003d, new GammaParticle(40901.0, 0.03031) }, { 0.626d, new GammaParticle(41541.0, 0.02985) }, { 0.19699999999999998d, new GammaParticle(47146.0, 0.0263) }, { 0.248d, new GammaParticle(47645.0, 0.02602) }, { 0.0509d, new GammaParticle(48248.0, 0.0257) } } },

        };
    }
}
    