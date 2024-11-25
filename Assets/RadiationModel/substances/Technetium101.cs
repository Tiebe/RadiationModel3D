using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium101";
        public override double halfLife { get; } = 853.2d;
        public override double atomicWeight { get; } = 100.9073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium101() }, { 1.0d, new BetaParticle(-1, 806550.0) }, { 0.0262552d, new GammaParticle(127220.0, 0.00975) }, { 0.0057655d, new GammaParticle(179600.0, 0.0069) }, { 0.015966d, new GammaParticle(184120.0, 0.00673) }, { 0.002661d, new GammaParticle(233700.0, 0.00531) }, { 0.0029980600000000003d, new GammaParticle(238250.0, 0.0052) }, { 0.0002661d, new GammaParticle(281600.0, 0.0044) }, { 0.00048785d, new GammaParticle(295170.0, 0.0042) }, { 0.887d, new GammaParticle(306830.0, 0.00404) }, { 0.00209332d, new GammaParticle(311280.0, 0.00398) }, { 0.00036366999999999997d, new GammaParticle(322010.0, 0.00385) }, { 0.00028384d, new GammaParticle(383830.0, 0.00323) }, { 0.00100231d, new GammaParticle(393300.0, 0.00315) }, { 0.00031932d, new GammaParticle(422020.0, 0.00294) }, { 0.00032819d, new GammaParticle(489100.0, 0.00253) }, { 0.00098457d, new GammaParticle(516130.0, 0.0024) }, { 0.0100231d, new GammaParticle(531420.0, 0.00233) }, { 0.0596064d, new GammaParticle(545050.0, 0.00227) }, { 0.00015079d, new GammaParticle(616300.0, 0.00201) }, { 0.0005322d, new GammaParticle(617310.0, 0.00201) }, { 0.00082491d, new GammaParticle(621990.0, 0.00199) }, { 0.0043463d, new GammaParticle(627000.0, 0.00198) }, { 0.00039914999999999997d, new GammaParticle(631740.0, 0.00196) }, { 0.00031045d, new GammaParticle(673400.0, 0.00184) }, { 0.00054107d, new GammaParticle(694300.0, 0.00179) }, { 0.0067412d, new GammaParticle(715530.0, 0.00173) }, { 0.00214654d, new GammaParticle(720020.0, 0.00172) }, { 0.00057655d, new GammaParticle(811130.0, 0.00153) }, { 0.00224411d, new GammaParticle(842730.0, 0.00147) }, { 0.0005322d, new GammaParticle(911570.0, 0.00136) }, { 0.00110875d, new GammaParticle(928720.0, 0.00134) }, { 0.00082491d, new GammaParticle(938650.0, 0.00132) }, { 0.0009098109588331681d, new GammaParticle(2737.0, 0.45299) }, { 0.004086704355714072d, new GammaParticle(19150.0, 0.06474) }, { 0.007754657221468827d, new GammaParticle(19279.0, 0.06431) }, { 0.0020839573515782296d, new GammaParticle(21736.0, 0.05704) }, { 0.0024215584425339026d, new GammaParticle(21875.0, 0.05668) }, { 0.0003376010909556732d, new GammaParticle(22072.0, 0.05617) } } },

        };
    }
}
    