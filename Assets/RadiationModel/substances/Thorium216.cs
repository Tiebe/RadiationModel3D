using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium216";
        public override double halfLife { get; } = 0.026d;
        public override double atomicWeight { get; } = 216.01106d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium212() }, { 1.0d, new AlphaParticle(9095002.09) }, { 0.0039000000000000003d, new GammaParticle(629300.0, 0.00197) }, { 3.1815437472e-05d, new GammaParticle(14920.0, 0.0831) }, { 1.8061236536113452e-05d, new GammaParticle(85432.0, 0.01451) }, { 2.9502183169084372e-05d, new GammaParticle(88471.0, 0.01401) }, { 1.035077431837513e-05d, new GammaParticle(100119.0, 0.01238) }, { 1.3745828294802172e-05d, new GammaParticle(101370.0, 0.01223) }, { 3.395053976427043e-06d, new GammaParticle(102948.0, 0.01204) } } },
            { 0.0001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium216() }, { 1.0d, new BetaParticle(1, 3504000.0) } } },

        };
    }
}
    