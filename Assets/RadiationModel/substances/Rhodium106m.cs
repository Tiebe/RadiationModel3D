using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium106m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium106m";
        public override double halfLife { get; } = 7860.0d;
        public override double atomicWeight { get; } = 105.90743d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium106() }, { 1.0d, new BetaParticle(-1, 1838250.0) }, { 0.005985000000000001d, new GammaParticle(195100.0, 0.00635) }, { 0.064125d, new GammaParticle(221800.0, 0.00559) }, { 0.02052d, new GammaParticle(228600.0, 0.00542) }, { 0.00855d, new GammaParticle(319600.0, 0.00388) }, { 0.011970000000000001d, new GammaParticle(328300.0, 0.00378) }, { 0.002736d, new GammaParticle(374500.0, 0.00331) }, { 0.035055d, new GammaParticle(390800.0, 0.00317) }, { 0.11628d, new GammaParticle(406000.0, 0.00305) }, { 0.005985000000000001d, new GammaParticle(419200.0, 0.00296) }, { 0.132525d, new GammaParticle(429400.0, 0.00289) }, { 0.0017100000000000001d, new GammaParticle(433900.0, 0.00286) }, { 0.241965d, new GammaParticle(450800.0, 0.00275) }, { 0.00855d, new GammaParticle(473200.0, 0.00262) }, { 0.855d, new GammaParticle(511700.0, 0.00242) }, { 0.00855d, new GammaParticle(586000.0, 0.00212) }, { 0.029925d, new GammaParticle(601200.0, 0.00206) }, { 0.20178000000000001d, new GammaParticle(616100.0, 0.00201) }, { 0.027360000000000002d, new GammaParticle(645800.0, 0.00192) }, { 0.01881d, new GammaParticle(680600.0, 0.00182) }, { 0.04446d, new GammaParticle(703100.0, 0.00176) }, { 0.28899d, new GammaParticle(717200.0, 0.00173) }, { 0.19323d, new GammaParticle(748500.0, 0.00166) }, { 0.05643d, new GammaParticle(793800.0, 0.00156) }, { 0.12996d, new GammaParticle(804600.0, 0.00154) }, { 0.074385d, new GammaParticle(808400.0, 0.00153) }, { 0.135945d, new GammaParticle(825000.0, 0.0015) }, { 0.016245d, new GammaParticle(848000.0, 0.00146) }, { 0.019665d, new GammaParticle(848000.0, 0.00146) }, { 0.004788d, new GammaParticle(956200.0, 0.0013) }, { 0.019665d, new GammaParticle(1020500.0, 0.00121) }, { 0.303525d, new GammaParticle(1046700.0, 0.00118) }, { 0.006840000000000001d, new GammaParticle(1122000.0, 0.00111) }, { 0.1368d, new GammaParticle(1127700.0, 0.0011) }, { 0.004275d, new GammaParticle(1136800.0, 0.00109) }, { 0.113715d, new GammaParticle(1200500.0, 0.00103) }, { 0.081225d, new GammaParticle(1224200.0, 0.00101) }, { 0.028215d, new GammaParticle(1395500.0, 0.00089) }, { 0.175275d, new GammaParticle(1529400.0, 0.00081) }, { 0.005985000000000001d, new GammaParticle(1565400.0, 0.00079) }, { 0.06669d, new GammaParticle(1573900.0, 0.00079) }, { 0.02223d, new GammaParticle(1724600.0, 0.00072) }, { 0.01881d, new GammaParticle(1840600.0, 0.00067) }, { 0.00075365350268184d, new GammaParticle(3053.0, 0.40611) }, { 0.0029971856573642788d, new GammaParticle(21020.0, 0.05898) }, { 0.005662546112534061d, new GammaParticle(21177.0, 0.05855) }, { 0.0015535706824800527d, new GammaParticle(23904.0, 0.05187) }, { 0.0018176776985016616d, new GammaParticle(24070.0, 0.05151) }, { 0.000264107016021609d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    