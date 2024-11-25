using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium226";
        public override double halfLife { get; } = 105732.0d;
        public override double atomicWeight { get; } = 226.0261d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium226() }, { 1.0d, new BetaParticle(-1, 555500.0) }, { 0.005600000000000001d, new GammaParticle(72230.0, 0.01717) }, { 1.8e-05d, new GammaParticle(81000.0, 0.01531) }, { 7.5e-06d, new GammaParticle(154230.0, 0.00804) }, { 0.175d, new GammaParticle(158050.0, 0.00784) }, { 0.26899999999999996d, new GammaParticle(230000.0, 0.00539) }, { 0.00043d, new GammaParticle(235300.0, 0.00527) }, { 0.00048d, new GammaParticle(540400.0, 0.00229) }, { 0.0007000000000000001d, new GammaParticle(574500.0, 0.00216) }, { 0.00043d, new GammaParticle(617400.0, 0.00201) }, { 0.121584075305308d, new GammaParticle(15784.0, 0.07855) }, { 0.010747483719714044d, new GammaParticle(89954.0, 0.01378) }, { 0.017385124101769723d, new GammaParticle(93347.0, 0.01328) }, { 0.006186227897917898d, new GammaParticle(105566.0, 0.01174) }, { 0.008270986699516229d, new GammaParticle(106894.0, 0.0116) }, { 0.0020847588015983315d, new GammaParticle(108580.0, 0.01142) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium226() }, { 0.0011d, new GammaParticle(67600.0, 0.01834) }, { 0.048d, new GammaParticle(185600.0, 0.00668) }, { 0.057d, new GammaParticle(253500.0, 0.00489) }, { 0.085492381976d, new GammaParticle(14920.0, 0.0831) }, { 0.03647493752149172d, new GammaParticle(85432.0, 0.01451) }, { 0.05958010049247259d, new GammaParticle(88471.0, 0.01401) }, { 0.020903543664183497d, new GammaParticle(100119.0, 0.01238) }, { 0.02775990598603568d, new GammaParticle(101370.0, 0.01223) }, { 0.006856362321852186d, new GammaParticle(102948.0, 0.01204) } } },
            { 6e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium222() }, { 1.0d, new AlphaParticle(6528002.09) } } },

        };
    }
}
    