using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium154";
        public override double halfLife { get; } = 8.1d;
        public override double atomicWeight { get; } = 153.94157d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.54d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium150() }, { 1.0d, new AlphaParticle(6116002.09) } } },
            { 0.46d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium154() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.033d, new GammaParticle(460500.0, 0.00269) }, { 0.24d, new GammaParticle(541900.0, 0.00229) }, { 0.46d, new GammaParticle(560800.0, 0.00221) }, { 0.42d, new GammaParticle(560800.0, 0.00221) }, { 0.4d, new GammaParticle(601400.0, 0.00206) }, { 0.37d, new GammaParticle(625400.0, 0.00198) }, { 0.083d, new GammaParticle(796000.0, 0.00156) }, { 0.00294385824144d, new GammaParticle(7933.0, 0.15629) }, { 0.0010107853056d, new GammaParticle(7933.0, 0.15629) }, { 0.0012275585097949902d, new GammaParticle(48222.0, 0.02571) }, { 0.003587668332921021d, new GammaParticle(48222.0, 0.02571) }, { 0.006367888414840293d, new GammaParticle(49128.0, 0.02524) }, { 0.0021788400954827654d, new GammaParticle(49128.0, 0.02524) }, { 0.002069333581141816d, new GammaParticle(55779.0, 0.02223) }, { 0.0007080442815255905d, new GammaParticle(55779.0, 0.02223) }, { 0.0008921357947222441d, new GammaParticle(56399.0, 0.02198) }, { 0.002607360312238688d, new GammaParticle(56399.0, 0.02198) }, { 0.0005380267310968721d, new GammaParticle(57145.0, 0.0217) }, { 0.00018409151319665352d, new GammaParticle(57145.0, 0.0217) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    