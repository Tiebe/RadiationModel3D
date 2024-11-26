using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium139";
        public override double halfLife { get; } = 11891232.0d;
        public override double atomicWeight { get; } = 138.90665d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum139() }, { 0.799d, new GammaParticle(165857.5, 0.00748) }, { 0.11948643569196676d, new GammaParticle(5185.0, 0.23912) }, { 0.2249387034509511d, new GammaParticle(33034.0, 0.03753) }, { 0.413186450130329d, new GammaParticle(33442.0, 0.03707) }, { 0.12304153001216064d, new GammaParticle(37908.0, 0.03271) }, { 0.15417103710523727d, new GammaParticle(38273.0, 0.03239) }, { 0.031129507093076644d, new GammaParticle(38725.0, 0.03202) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    