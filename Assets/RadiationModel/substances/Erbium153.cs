using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium153";
        public override double halfLife { get; } = 37.1d;
        public override double atomicWeight { get; } = 152.93509d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.53d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium149() }, { 1.0d, new AlphaParticle(5824002.09) } } },
            { 0.47d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium153() }, { 1.0d, new BetaParticle(1, 4338000.0) }, { 0.00032d, new GammaParticle(94500.0, 0.01312) }, { 0.07200000000000001d, new GammaParticle(188000.0, 0.00659) }, { 0.213d, new GammaParticle(351200.0, 0.00353) }, { 0.062d, new GammaParticle(377500.0, 0.00328) }, { 0.115d, new GammaParticle(398400.0, 0.00311) }, { 0.017d, new GammaParticle(449400.0, 0.00276) }, { 0.0128d, new GammaParticle(463600.0, 0.00267) }, { 0.0064d, new GammaParticle(565500.0, 0.00219) }, { 0.0106d, new GammaParticle(575400.0, 0.00215) }, { 0.026000000000000002d, new GammaParticle(1150600.0, 0.00108) }, { 0.0149d, new GammaParticle(1166400.0, 0.00106) }, { 0.0255d, new GammaParticle(1301400.0, 0.00095) }, { 0.032d, new GammaParticle(1348900.0, 0.00092) }, { 0.0064d, new GammaParticle(1700100.0, 0.00073) }, { 0.41938000000000003d, new GammaParticle(511000.0, 0.00243) }, { 0.049800000000000004d, new GammaParticle(7656.0, 0.16194) }, { 0.0653d, new GammaParticle(46700.0, 0.02655) }, { 0.11599999999999999d, new GammaParticle(47547.0, 0.02608) }, { 0.037599999999999995d, new GammaParticle(53982.0, 0.02297) }, { 0.047400000000000005d, new GammaParticle(54577.0, 0.02272) }, { 0.0098d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    