using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium211";
        public override double halfLife { get; } = 13.0d;
        public override double atomicWeight { get; } = 211.00089d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon207() }, { 1.0d, new AlphaParticle(8064002.09) }, { 1.1999999999999999e-05d, new GammaParticle(120000.0, 0.01033) }, { 5.500000000000001e-06d, new GammaParticle(665000.0, 0.00186) }, { 2.673138152064e-05d, new GammaParticle(14088.0, 0.08801) }, { 1.535790328597211e-05d, new GammaParticle(81070.0, 0.01529) }, { 2.5334713437763295e-05d, new GammaParticle(83789.0, 0.0148) }, { 8.785905883533781e-06d, new GammaParticle(94878.0, 0.01307) }, { 1.1597395766264591e-05d, new GammaParticle(96054.0, 0.01291) }, { 2.81148988273081e-06d, new GammaParticle(97530.0, 0.01271) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon211() }, { 1.0d, new BetaParticle(1, 4793500.0) } } },

        };
    }
}
    