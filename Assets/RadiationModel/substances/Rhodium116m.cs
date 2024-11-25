using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium116m";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 115.92427d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium116() }, { 1.0d, new BetaParticle(-1, 4645500.0) }, { 0.00968d, new GammaParticle(172400.0, 0.00719) }, { 0.0132d, new GammaParticle(269500.0, 0.0046) }, { 0.0308d, new GammaParticle(287700.0, 0.00431) }, { 0.02904d, new GammaParticle(293200.0, 0.00423) }, { 0.16808d, new GammaParticle(328400.0, 0.00378) }, { 0.88d, new GammaParticle(340300.0, 0.00364) }, { 0.16896d, new GammaParticle(397700.0, 0.00312) }, { 0.0088d, new GammaParticle(420500.0, 0.00295) }, { 0.01056d, new GammaParticle(437100.0, 0.00284) }, { 0.02376d, new GammaParticle(453000.0, 0.00274) }, { 0.034319999999999996d, new GammaParticle(465800.0, 0.00266) }, { 0.11263999999999999d, new GammaParticle(466100.0, 0.00266) }, { 0.02552d, new GammaParticle(495500.0, 0.0025) }, { 0.46552d, new GammaParticle(537300.0, 0.00231) }, { 0.0176d, new GammaParticle(553500.0, 0.00224) }, { 0.022000000000000002d, new GammaParticle(557400.0, 0.00222) }, { 0.0264d, new GammaParticle(609400.0, 0.00203) }, { 0.07216d, new GammaParticle(620900.0, 0.002) }, { 0.07656d, new GammaParticle(628900.0, 0.00197) }, { 0.07304000000000001d, new GammaParticle(635300.0, 0.00195) }, { 0.17071999999999998d, new GammaParticle(638700.0, 0.00194) }, { 0.09768d, new GammaParticle(652000.0, 0.0019) }, { 0.13992000000000002d, new GammaParticle(681400.0, 0.00182) }, { 0.01672d, new GammaParticle(714500.0, 0.00174) }, { 0.24552d, new GammaParticle(725900.0, 0.00171) }, { 0.01056d, new GammaParticle(728000.0, 0.0017) }, { 0.11616d, new GammaParticle(737800.0, 0.00168) }, { 0.22440000000000002d, new GammaParticle(743600.0, 0.00167) }, { 0.01056d, new GammaParticle(773400.0, 0.0016) }, { 0.00968d, new GammaParticle(784400.0, 0.00158) }, { 0.08448d, new GammaParticle(876500.0, 0.00141) }, { 0.00528d, new GammaParticle(886500.0, 0.0014) }, { 0.00528d, new GammaParticle(889500.0, 0.00139) }, { 0.01232d, new GammaParticle(899000.0, 0.00138) }, { 0.01232d, new GammaParticle(942500.0, 0.00132) }, { 0.043120000000000006d, new GammaParticle(957000.0, 0.0013) }, { 0.01056d, new GammaParticle(1044200.0, 0.00119) }, { 0.011439999999999999d, new GammaParticle(1058700.0, 0.00117) }, { 0.007039999999999999d, new GammaParticle(1095300.0, 0.00113) }, { 0.19976d, new GammaParticle(1104700.0, 0.00112) }, { 0.01232d, new GammaParticle(1159000.0, 0.00107) }, { 0.00616d, new GammaParticle(1253500.0, 0.00099) }, { 0.0088d, new GammaParticle(1437700.0, 0.00086) }, { 0.01848d, new GammaParticle(1455500.0, 0.00085) } } },

        };
    }
}
    