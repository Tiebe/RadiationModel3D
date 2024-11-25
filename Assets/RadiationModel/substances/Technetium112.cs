using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium112";
        public override double halfLife { get; } = 0.271d;
        public override double atomicWeight { get; } = 111.92994d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium112() }, { 1.0d, new BetaParticle(-1, 5186000.0) }, { 0.047939999999999997d, new GammaParticle(152700.0, 0.00812) }, { 0.06392d, new GammaParticle(224000.0, 0.00554) }, { 0.799d, new GammaParticle(236800.0, 0.00524) }, { 0.26367d, new GammaParticle(287000.0, 0.00432) }, { 0.07191d, new GammaParticle(381700.0, 0.00325) }, { 0.11985d, new GammaParticle(408200.0, 0.00304) }, { 0.16779d, new GammaParticle(510800.0, 0.00243) }, { 0.19175999999999999d, new GammaParticle(523400.0, 0.00237) }, { 0.0013d, new GammaParticle(2737.0, 0.45299) }, { 0.006d, new GammaParticle(19150.0, 0.06474) }, { 0.011000000000000001d, new GammaParticle(19279.0, 0.06431) }, { 0.003d, new GammaParticle(21736.0, 0.05704) }, { 0.004d, new GammaParticle(21875.0, 0.05668) }, { 0.0005d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.015d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium112() }, { 1.0d, new BetaParticle(-1, 5186000.0) }, { 0.047939999999999997d, new GammaParticle(152700.0, 0.00812) }, { 0.06392d, new GammaParticle(224000.0, 0.00554) }, { 0.799d, new GammaParticle(236800.0, 0.00524) }, { 0.26367d, new GammaParticle(287000.0, 0.00432) }, { 0.07191d, new GammaParticle(381700.0, 0.00325) }, { 0.11985d, new GammaParticle(408200.0, 0.00304) }, { 0.16779d, new GammaParticle(510800.0, 0.00243) }, { 0.19175999999999999d, new GammaParticle(523400.0, 0.00237) }, { 0.0013d, new GammaParticle(2737.0, 0.45299) }, { 0.006d, new GammaParticle(19150.0, 0.06474) }, { 0.011000000000000001d, new GammaParticle(19279.0, 0.06431) }, { 0.003d, new GammaParticle(21736.0, 0.05704) }, { 0.004d, new GammaParticle(21875.0, 0.05668) }, { 0.0005d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    