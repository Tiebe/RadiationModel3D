using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium81";
        public override double halfLife { get; } = 1107.0d;
        public override double atomicWeight { get; } = 80.91799d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine81() }, { 1.0d, new BetaParticle(-1, 794050.0) }, { 5.78e-05d, new GammaParticle(178260.0, 0.00696) }, { 0.0068000000000000005d, new GammaParticle(275930.0, 0.00449) }, { 0.0001496d, new GammaParticle(290000.0, 0.00428) }, { 0.005576d, new GammaParticle(290040.0, 0.00427) }, { 0.0004896d, new GammaParticle(538200.0, 0.0023) }, { 0.000884d, new GammaParticle(552420.0, 0.00224) }, { 0.002244d, new GammaParticle(566030.0, 0.00219) }, { 0.00025499999999999996d, new GammaParticle(649790.0, 0.00191) }, { 2.856e-05d, new GammaParticle(789100.0, 0.00157) }, { 0.002856d, new GammaParticle(828270.0, 0.0015) }, { 1.428e-05d, new GammaParticle(1352000.0, 0.00092) }, { 3.6000000000000003e-06d, new GammaParticle(1535.0, 0.80771) }, { 2.5200000000000003e-05d, new GammaParticle(11879.0, 0.10437) }, { 4.9e-05d, new GammaParticle(11925.0, 0.10397) }, { 1.15e-05d, new GammaParticle(13345.0, 0.09291) }, { 1.24e-05d, new GammaParticle(13377.0, 0.09268) }, { 8.9e-07d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    