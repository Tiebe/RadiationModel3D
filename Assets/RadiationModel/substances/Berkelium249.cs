using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium249";
        public override double halfLife { get; } = 28270080.0d;
        public override double atomicWeight { get; } = 249.07498d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999859999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium249() }, { 1.0d, new BetaParticle(-1, 61800.00001) } } },
            { 1.37e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Americium245() }, { 1.0d, new AlphaParticle(6542902.09) }, { 1.37e-08d, new GammaParticle(28000.0, 0.04428) }, { 1.37e-08d, new GammaParticle(280360.0, 0.00442) }, { 3.3000000000000004e-08d, new GammaParticle(308260.0, 0.00402) }, { 1.45e-07d, new GammaParticle(327450.0, 0.00379) }, { 9.05920732e-08d, new GammaParticle(18078.0, 0.06858) }, { 3.787195505165082e-08d, new GammaParticle(102031.0, 0.01215) }, { 5.962209548433694e-08d, new GammaParticle(106468.0, 0.01165) }, { 2.209865145482389e-08d, new GammaParticle(120157.0, 0.01032) }, { 2.983317946401225e-08d, new GammaParticle(121688.0, 0.01019) }, { 7.734528009188361e-09d, new GammaParticle(123677.0, 0.01002) } } },
            { 4.699999999999999e-10d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    