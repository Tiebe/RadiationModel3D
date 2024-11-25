using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium243";
        public override double halfLife { get; } = 232385202876.89548d;
        public override double atomicWeight { get; } = 243.06138d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium239() }, { 1.0d, new AlphaParticle(6461002.09) }, { 0.0007056d, new GammaParticle(31140.0, 0.03982) }, { 0.0006518400000000001d, new GammaParticle(43100.0, 0.02877) }, { 0.059001599999999994d, new GammaParticle(43530.0, 0.02848) }, { 2.9568e-05d, new GammaParticle(50600.0, 0.0245) }, { 0.000103488d, new GammaParticle(55400.0, 0.02238) }, { 3.36e-07d, new GammaParticle(68100.0, 0.01821) }, { 0.672d, new GammaParticle(74660.0, 0.01661) }, { 0.0034608d, new GammaParticle(86710.0, 0.0143) }, { 9.408e-05d, new GammaParticle(98500.0, 0.01259) }, { 0.0056448d, new GammaParticle(117600.0, 0.01054) }, { 0.00114912d, new GammaParticle(141890.0, 0.00874) }, { 1.344e-05d, new GammaParticle(169000.0, 0.00734) }, { 9.408e-06d, new GammaParticle(195000.0, 0.00636) }, { 3.36e-06d, new GammaParticle(631090.0, 0.00196) }, { 1.1424e-05d, new GammaParticle(662240.0, 0.00187) }, { 0.1896184623110475d, new GammaParticle(17136.0, 0.07235) }, { 5.768722934729564e-05d, new GammaParticle(97078.0, 0.01277) }, { 9.182940042549451e-05d, new GammaParticle(101068.0, 0.01227) }, { 3.3485495209531126e-05d, new GammaParticle(114160.0, 0.01086) }, { 4.500450556160984e-05d, new GammaParticle(115608.0, 0.01072) }, { 1.1519010352078708e-05d, new GammaParticle(117470.0, 0.01055) } } },
            { 3.7e-11d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    