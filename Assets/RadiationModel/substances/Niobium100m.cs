using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium100m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium100m";
        public override double halfLife { get; } = 2.99d;
        public override double atomicWeight { get; } = 99.91468d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum100() }, { 1.0d, new BetaParticle(-1, 3357250.0) }, { 0.02812d, new GammaParticle(159500.0, 0.00777) }, { 0.010360000000000001d, new GammaParticle(234500.0, 0.00529) }, { 0.06068d, new GammaParticle(461200.0, 0.00269) }, { 0.0074d, new GammaParticle(471200.0, 0.00263) }, { 0.00444d, new GammaParticle(495400.0, 0.0025) }, { 0.07696d, new GammaParticle(528263.0, 0.00235) }, { 0.74d, new GammaParticle(535666.0, 0.00231) }, { 0.0111d, new GammaParticle(538600.0, 0.0023) }, { 0.0407d, new GammaParticle(543200.0, 0.00228) }, { 0.0148d, new GammaParticle(549700.0, 0.00226) }, { 0.5402d, new GammaParticle(600500.0, 0.00206) }, { 0.0259d, new GammaParticle(635400.0, 0.00195) }, { 0.02812d, new GammaParticle(639000.0, 0.00194) }, { 0.01406d, new GammaParticle(681800.0, 0.00182) }, { 0.041440000000000005d, new GammaParticle(702700.0, 0.00176) }, { 0.04884d, new GammaParticle(707500.0, 0.00175) }, { 0.050320000000000004d, new GammaParticle(711000.0, 0.00174) }, { 0.03848d, new GammaParticle(768800.0, 0.00161) }, { 0.03108d, new GammaParticle(792800.0, 0.00156) }, { 0.02738d, new GammaParticle(928400.0, 0.00134) }, { 0.03626d, new GammaParticle(952500.0, 0.0013) }, { 0.12802d, new GammaParticle(966900.0, 0.00128) }, { 0.0074d, new GammaParticle(1045800.0, 0.00119) }, { 0.03256d, new GammaParticle(1063700.0, 0.00117) }, { 0.02812d, new GammaParticle(1071600.0, 0.00116) }, { 0.01998d, new GammaParticle(1246400.0, 0.00099) }, { 0.1739d, new GammaParticle(1280400.0, 0.00097) }, { 0.03108d, new GammaParticle(1427900.0, 0.00087) }, { 0.0296d, new GammaParticle(1516800.0, 0.00082) }, { 0.0444d, new GammaParticle(1567400.0, 0.00079) }, { 0.00888d, new GammaParticle(1779300.0, 0.0007) }, { 0.005180000000000001d, new GammaParticle(1800100.0, 0.00069) }, { 0.000431305450193064d, new GammaParticle(2440.0, 0.50813) }, { 0.002138673581001945d, new GammaParticle(17374.0, 0.07136) }, { 0.0040759931027290735d, new GammaParticle(17479.0, 0.07093) }, { 0.001069525826160295d, new GammaParticle(19681.0, 0.063) }, { 0.0012342328033889802d, new GammaParticle(19794.0, 0.06264) }, { 0.00016470697722868537d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    