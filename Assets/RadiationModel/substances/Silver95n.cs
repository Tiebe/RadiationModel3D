using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver95n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95n";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 94.9384d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver95() }, { 0.9116d, new GammaParticle(163800.0, 0.00757) }, { 0.9890000000000001d, new GammaParticle(427800.0, 0.0029) }, { 0.3096d, new GammaParticle(822600.0, 0.00151) }, { 0.688d, new GammaParticle(936500.0, 0.00132) }, { 0.602d, new GammaParticle(1003200.0, 0.00124) }, { 0.344d, new GammaParticle(1117100.0, 0.00111) }, { 0.0037795429821776d, new GammaParticle(3218.0, 0.38528) }, { 0.013931653900899715d, new GammaParticle(21990.0, 0.05638) }, { 0.026261364563430187d, new GammaParticle(22163.0, 0.05594) }, { 0.007275141757810991d, new GammaParticle(25030.0, 0.04953) }, { 0.008541016423670104d, new GammaParticle(25211.0, 0.04918) }, { 0.0012658746658591124d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    