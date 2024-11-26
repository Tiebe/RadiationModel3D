using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine133m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine133m";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 132.90958d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine133() }, { 0.0407d, new GammaParticle(74050.0, 0.01674) }, { 0.9956999999999999d, new GammaParticle(647510.0, 0.00191) }, { 0.9981d, new GammaParticle(912671.0, 0.00136) }, { 0.0785593481448412d, new GammaParticle(4335.0, 0.28601) }, { 0.18932079883731173d, new GammaParticle(28318.0, 0.04378) }, { 0.35163595623572014d, new GammaParticle(28613.0, 0.04333) }, { 0.1013080513578859d, new GammaParticle(32395.0, 0.03827) }, { 0.12420367096476811d, new GammaParticle(32680.0, 0.03794) }, { 0.022895619606882214d, new GammaParticle(33040.0, 0.03753) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    