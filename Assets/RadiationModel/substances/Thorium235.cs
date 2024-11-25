using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium235";
        public override double halfLife { get; } = 432.0d;
        public override double atomicWeight { get; } = 235.04726d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium235() }, { 1.0d, new BetaParticle(-1, 864500.0) }, { 0.0015199999999999999d, new GammaParticle(174800.0, 0.00709) }, { 0.00296d, new GammaParticle(292900.0, 0.00423) }, { 0.00298d, new GammaParticle(406100.0, 0.00305) }, { 0.02d, new GammaParticle(417000.0, 0.00297) }, { 0.003d, new GammaParticle(450400.0, 0.00275) }, { 0.00496d, new GammaParticle(468700.0, 0.00265) }, { 0.0038d, new GammaParticle(484200.0, 0.00256) }, { 0.005600000000000001d, new GammaParticle(644900.0, 0.00192) }, { 0.00642d, new GammaParticle(696100.0, 0.00178) }, { 0.00542d, new GammaParticle(704000.0, 0.00176) }, { 0.0051600000000000005d, new GammaParticle(708300.0, 0.00175) }, { 0.00866d, new GammaParticle(727200.0, 0.0017) }, { 0.00456d, new GammaParticle(729500.0, 0.0017) }, { 0.002d, new GammaParticle(737000.0, 0.00168) }, { 0.0043d, new GammaParticle(747800.0, 0.00166) }, { 0.0027400000000000002d, new GammaParticle(837800.0, 0.00148) }, { 0.0042d, new GammaParticle(932800.0, 0.00133) } } },

        };
    }
}
    