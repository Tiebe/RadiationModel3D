using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron65 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron65";
        public override double halfLife { get; } = 0.81d;
        public override double atomicWeight { get; } = 64.94502d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt65() }, { 1.0d, new BetaParticle(-1, 3983600.0) }, { 0.020366d, new GammaParticle(127600.0, 0.00972) }, { 0.066489d, new GammaParticle(212500.0, 0.00583) }, { 0.28153d, new GammaParticle(340070.0, 0.00365) }, { 0.13178d, new GammaParticle(736100.0, 0.00168) }, { 0.03594d, new GammaParticle(774000.0, 0.0016) }, { 0.010782d, new GammaParticle(864000.0, 0.00144) }, { 0.599d, new GammaParticle(882500.0, 0.0014) }, { 0.05391d, new GammaParticle(960500.0, 0.00129) }, { 0.049717000000000004d, new GammaParticle(1076200.0, 0.00115) }, { 0.023361d, new GammaParticle(1088700.0, 0.00114) }, { 0.08985d, new GammaParticle(1113500.0, 0.00111) }, { 0.13777d, new GammaParticle(1222700.0, 0.00101) }, { 0.26356d, new GammaParticle(1996600.0, 0.00062) } } },

        };
    }
}
    