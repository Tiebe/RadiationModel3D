using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium47";
        public override double halfLife { get; } = 17.5d;
        public override double atomicWeight { get; } = 46.96166d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium47() }, { 1.0d, new BetaParticle(-1, 3316350.0) }, { 0.1327437d, new GammaParticle(564790.0, 0.0022) }, { 0.7972090000000001d, new GammaParticle(586010.0, 0.00212) }, { 0.9335d, new GammaParticle(2013450.0, 0.00062) }, { 0.012135499999999999d, new GammaParticle(2511100.0, 0.00049) }, { 0.05601d, new GammaParticle(2578260.0, 0.00048) }, { 0.0104552d, new GammaParticle(2599400.0, 0.00048) }, { 4.873882075404017e-07d, new GammaParticle(358.0, 3.46325) }, { 6.495697259352556e-06d, new GammaParticle(3688.0, 0.33618) }, { 1.2834809838673297e-05d, new GammaParticle(3692.0, 0.33582) }, { 2.5052337199041503e-06d, new GammaParticle(4013.0, 0.30896) }, { 2.5052337199041503e-06d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    